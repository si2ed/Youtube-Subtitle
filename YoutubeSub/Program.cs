using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using YoutubeSub.Model;

namespace YoutubeSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + "subs\\";

            //links.json is the place we put our links in it
            JObject o1 = JObject.Parse(File.ReadAllText("..\\..\\links.json"));
            JArray a1 = (JArray)o1["links"];
            IList<string> links = a1.ToObject<IList<string>>();
            links = links.Distinct().ToList();

            List<string> errors = new List<string>();
            foreach (string link in links)
            {
                try
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument doc = web.Load(link);

                    string tex = doc.ParsedText;
                    var ct = tex.Split(new string[] { "ytInitialPlayerResponse = " }, StringSplitOptions.None)[1].Split(new string[] { ";</script>" }, StringSplitOptions.None)[0];

                    var model = JsonConvert.DeserializeObject<JsonModel>(ct);
                    string title = model.videoDetails.title + " - " + model.videoDetails.author;

                    //normalize file name
                    title = title.Replace(":", "");
                    title = title.Replace("\"", "");
                    title = title.Replace("'", "");
                    title = title.Replace("!", "");
                    title = title.Replace("?", "");
                    title = title.Replace("|", "");
                    title = title.Replace("*", "");
                    title = title.Replace("/", "");


                    if (model.captions != null)
                    {
                        var getBaseUrl = model.captions.playerCaptionsTracklistRenderer.captionTracks.Where(a => a.languageCode == "en").FirstOrDefault();
                        if (getBaseUrl != null)
                        {

                            var baseUrl = getBaseUrl.baseUrl;

                            XmlDocument doc1 = new XmlDocument();
                            doc1.Load(baseUrl);
                            XmlElement root = doc1.DocumentElement;
                            XmlNodeList nodes = root.SelectNodes("/transcript/text");

                            string text = string.Empty;
                            foreach (XmlNode node in nodes)
                            {
                                string txt = HttpUtility.HtmlDecode(node.InnerText);
                                text += string.Format("   {0}", txt);
                            }

                            File.WriteAllText(dir + title + ".txt", text);

                        }
                    }
                }
                catch (Exception ex)
                {
                    errors.Add(link);
                }
            }
        }
    }
}
