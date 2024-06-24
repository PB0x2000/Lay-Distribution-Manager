using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Lay_Distribution_Manager
{
    internal class Spotify
    {
        private static string BASIC = "MWQ3OWZmNzU1ZWQwNGEyYzhlMzI2OGI3N2Q1ZmNkN2Y6MDk1NDA0ZGY0ZGM3NGYwNzg1MTA2NGRmOWU4MDI3ZmM=";
        private static Objects.SpotifyAUTH current_auth = new Objects.SpotifyAUTH();

        public static void getData()
        {
            if(current_auth.token == null || current_auth.timestamp < new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds())
            {
                Objects.requestOBJ.AddHeader("Authorization", "Basic " + BASIC);
                string response = Objects.requestOBJ.Post("https://accounts.spotify.com/api/token", "grant_type=client_credentials", "application/x-www-form-urlencoded").ToString();
                current_auth.token = Regex.Match(response, @"access_token"":""(.+?)""").Groups[1].Value;
                current_auth.timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + 3500;
            }
            Objects.requestOBJ.AddHeader("Authorization", "Bearer " + current_auth.token);

            //CODE TO GET SOMETHING FROM SPOTIFY
        }
    }
}
