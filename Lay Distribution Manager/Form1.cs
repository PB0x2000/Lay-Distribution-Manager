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
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Diagnostics.Contracts;

namespace Lay_Distribution_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Objects.requestOBJ.IgnoreProtocolErrors= true;
            Objects.requestOBJ.AllowAutoRedirect= true;
            Objects.languages = JsonConvert.DeserializeObject<List<Objects.Language>>(File.ReadAllText(@"Data\languages.json"));
            Objects.genres = JsonConvert.DeserializeObject<List<Objects.Genre>>(File.ReadAllText(@"Data\genres.json"));

        }
        void inspection_queue_Click(object sender, EventArgs e, string name, Panel panel, Objects.GetInspectionItem item)
        {
            try
            {
                if (Objects.currentInspection != null)
                {
                    Objects.currentInspection.panel.BorderStyle = BorderStyle.FixedSingle;
                    Objects.currentInspection.panel.Padding = new Padding(1);
                    Objects.currentInspection.panel.BackColor = Color.Black;
                }
                Objects.currentInspection = new Objects.CurrentInspection();
                Objects.currentInspection.name = name;
                Objects.currentInspection.panel = panel;
                Objects.currentInspection.item = item;
                Objects.currentInspection.panel.BorderStyle = BorderStyle.FixedSingle;
                Objects.currentInspection.panel.Padding = new Padding(3);
                Objects.currentInspection.panel.BackColor = Color.Green;
                label_INSPECTION_TITLE.Text = item.release.releaseId.ToString();
            }
            catch (Exception ex)
            {
                File.AppendAllText("debug.txt", ex.ToString() + "\n\n\n");
            }
        }    
        void inspection_artist_Click(object sender, EventArgs e, string name)
        {
            Process.Start(new System.Diagnostics.ProcessStartInfo(("https://open.spotify.com/intl-de/artist/" + name)) { UseShellExecute = true });
        }
        void inspection_ACR_Click(object sender, EventArgs e, string name)
        {
            if (name.Split('|')[0] == "y")
            {
                Process.Start(new System.Diagnostics.ProcessStartInfo(("https://www.youtube.com/watch?v=" + name.Split('|')[1])) { UseShellExecute = true });
            }
            if (name.Split('|')[0] == "d")
            {
                Process.Start(new System.Diagnostics.ProcessStartInfo(("https://www.deezer.com/de/track/" + name.Split('|')[1])) { UseShellExecute = true });
            }
            if (name.Split('|')[0] == "s")
            {
                Process.Start(new System.Diagnostics.ProcessStartInfo(("https://open.spotify.com/intl-de/track/" + name.Split('|')[1])) { UseShellExecute = true });
            }
        }
        void inspection_Track_open(object sender, EventArgs e, string name)
        {
            Process.Start(new System.Diagnostics.ProcessStartInfo(("https://revelator-cdn.azureedge.net/music/" + name + "/file.wav")) { UseShellExecute = true });
        }
        void inspection_Track_Click(object sender, EventArgs e, string name)
        {
            //TMP LIST ADDED IDS
            List<string> tmp_ids = new List<string>();
            int index = 1;
            int offset = 50;

            //ACR ADD PANELS
            foreach (Objects.GetCurrentInspectionDataScan scan in Objects.currentInspection_DATA.tracks.SingleOrDefault(item => item.trackId.ToString() == name).acrCloud.scans)
            {
                if(scan.matches != null)
                {
                    //CREATE PANEL
                    Panel panel_song_ACR = new Panel();
                    panel_song_ACR.Name = Objects.currentInspection_DATA.releaseId.ToString();
                    panel_song_ACR.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    panel_song_ACR.Size = new System.Drawing.Size(670, 60);
                    panel_song_ACR.TabIndex = 1;

                    //ADD CONTROLS TO PANEL
                    foreach (var match in scan.matches)
                    {
                        Label to_inspect_ISRC = new Label
                        {
                            Size = new Size(40, 40),
                            Location = new Point(10, 10),
                            Text = index.ToString(),
                            ForeColor = Color.White,
                            Font = new Font("Arial", 20, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        to_inspect_ISRC.Click += new EventHandler((senderr, ee) => inspection_Track_open(sender, e, Objects.currentInspection_DATA.tracks.SingleOrDefault(item => item.trackId.ToString() == name).wav.fileId));

                        Objects.ACR_JSON acr_json = JsonConvert.DeserializeObject<Objects.ACR_JSON>(match.sources.Replace("\n", "").Replace("\r", "").Replace(@"\""", @""""), Objects.json_settings);
                        if (acr_json.youtube != null && !tmp_ids.Contains(acr_json.youtube.vid))
                        {
                            PictureBox artist_image = new PictureBox
                            {
                                Size = new Size(55, 55),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Location = new Point(offset, 0)
                            };

                            artist_image.Image = (Image)Properties.Resources.YouTube;

                            //Image ON CLICK EVENT
                            artist_image.Click += new EventHandler((senderr, ee) => inspection_ACR_Click(sender, e, ("y|" + acr_json.youtube.vid)));
                            tmp_ids.Add(acr_json.youtube.vid);
                            panel_song_ACR.Controls.Add(artist_image);
                            offset += 60;
                        }
                        if (acr_json.deezer != null && !tmp_ids.Contains(acr_json.deezer.track.id))
                        {
                            PictureBox artist_image = new PictureBox
                            {
                                Size = new Size(55, 55),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Location = new Point(offset, 0)
                            };

                            artist_image.Image = (Image)Properties.Resources.Deezer;

                            //Image ON CLICK EVENT
                            artist_image.Click += new EventHandler((senderr, ee) => inspection_ACR_Click(sender, e, ("d|" + acr_json.deezer.track.id)));
                            tmp_ids.Add(acr_json.deezer.track.id);
                            panel_song_ACR.Controls.Add(artist_image);
                            offset += 60;
                        }
                        if (acr_json.spotify != null && !tmp_ids.Contains(acr_json.spotify.track.id))
                        {
                            PictureBox artist_image = new PictureBox
                            {
                                Size = new Size(55, 55),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Location = new Point(offset, 0)
                            };

                            artist_image.Image = (Image)Properties.Resources.SpotifyICO;

                            //Image ON CLICK EVENT
                            artist_image.Click += new EventHandler((senderr, ee) => inspection_ACR_Click(sender, e, ("s|" + acr_json.spotify.track.id)));
                            tmp_ids.Add(acr_json.spotify.track.id);
                            panel_song_ACR.Controls.Add(artist_image);
                            offset += 60;
                        }
                        if(panel_song_ACR.Controls.Count != 0)
                        {
                            index++;
                            panel_song_ACR.Controls.Add(to_inspect_ISRC);
                        }
                    }
                    flowLayoutPanel_INSPECTION_ACR.Controls.Add(panel_song_ACR);
                }
            }


        }
        private void button_INSPECTION_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_RELEASES.Controls.Clear();

            #region ENABLE ALL THINGS IN INSPECTION PANEL
            panel_CONTENT_INSPECTION.Enabled = true;
            panel_CONTENT_INSPECTION.Visible = true;
            button_INSPECTION_APPROVE.Enabled = true;
            button_INSPECTION_APPROVE.Visible = true;
            button_INSPECTION_DENY.Enabled = true;
            button_INSPECTION_DENY.Visible = true;
            button_INSPECTION_GETDATA.Enabled = true;
            button_INSPECTION_GETDATA.Visible = true;
            flowLayoutPanel_INSPECTION_ARTISTS.Enabled = true;
            flowLayoutPanel_INSPECTION_ARTISTS.Visible = true;
            label_INSPECTION_INFO.Enabled= true;
            label_INSPECTION_INFO.Visible= true;
            #endregion

            Objects.GetInspection inspection_data = JsonConvert.DeserializeObject<Objects.GetInspection>(Objects.requestOBJ.Get(("https://api.revelator.com/distribution/release/all/grid?orderByDescending=true&orderByProperty=Lastaddeddate&pageNumber=1&pageSize=100&summarySection%5B0%5D=10&token=" + textBox_AUTH.Text)).ToString(), Objects.json_settings);
            foreach (Objects.GetInspectionItem item in inspection_data.items)
            {
                //CREATE PANEL
                Panel to_inspect = new Panel();
                to_inspect.Name = item.release.releaseId.ToString();
                to_inspect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                to_inspect.Size = new System.Drawing.Size(275, 340);
                to_inspect.TabIndex = 1;

                //ADD CONTROLS TO PANEL
                PictureBox to_inspect_image = new PictureBox 
                {
                    Size = new Size(270, 270),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(0, 0)
                };
                to_inspect_image.LoadAsync("https://api.revelator.com/media/image/" + item.release.image.fileId + "?maxWidth=1000&maxHeight=1000");
                Label to_inspect_label_name = new Label
                {
                    Size = new Size(270, 30),
                    Location = new Point(0, 280),
                    Text = item.release.name + " [ " + item.release.version + " ]\n" + item.release.artistName,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label to_inspect_label_UPC = new Label
                {
                    Size = new Size(270, 30),
                    Location = new Point(0, 305),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                if (item.release.upc != null)
                {
                    to_inspect_label_UPC.Text = "UPC [ " + item.release.upc.ToString() + " ]";
                }
                else
                {
                    to_inspect_label_UPC.Text = "UPC [ - ]";
                }
                to_inspect.Controls.Add(to_inspect_image);
                to_inspect.Controls.Add(to_inspect_label_name);
                to_inspect.Controls.Add(to_inspect_label_UPC);

                //PANEL ON CLICK EVENT
                to_inspect_image.Click += new EventHandler((senderr, ee) => inspection_queue_Click(sender, e, item.release.releaseId.ToString(), to_inspect, item));

                //ADD PANEL TO FLOWPANEL
                flowLayoutPanel_RELEASES.Controls.Add(to_inspect);
            }
        }
        private void button_INSPECTION_APPROVE_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://api.revelator.com/distribution/release/approve?releaseId=" + Objects.currentInspection.item.releaseId + "&token=" + textBox_AUTH.Text;
                HttpResponse response = Objects.requestOBJ.Post(url, Objects.currentInspection.item.releaseId.ToString(), "application/json");
                label_INSPECTION_TITLE.Text = response.StatusCode.ToString();
                if (response.StatusCode == Leaf.xNet.HttpStatusCode.NoContent || response.StatusCode == Leaf.xNet.HttpStatusCode.BadRequest)
                {
                    Control control = flowLayoutPanel_RELEASES.Controls.Find(Objects.currentInspection.name, true)[0];
                    flowLayoutPanel_RELEASES.Controls.Remove(control);
                    control.Dispose();
                    label_INSPECTION_INFO.Text = @"TITLE
ARTIST
UPC
EMAIL
LANGUAGE
GENRE
LABEL
COPYRIGHT";
                    Objects.currentInspection = null;
                    Objects.currentInspection_DATA = null;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("debug.txt", ex.ToString() + "\n\n\n");
            }
        }
        private void button_INSPECTION_DENY_Click(object sender, EventArgs e)
        {
            try
            {
                string payload = "\"<b>Refusal & Closure for streaming abuse / suspect audio files</b><br><br><div>We cannot accept this title because it violates our usage guidelines. For this reason, your account has been disabled. All future accounts will also get locked. Please email us if you have further questions.</div><br>\"";
                string url = "https://api.revelator.com/distribution/release/reject?releaseId=" + Objects.currentInspection.item.releaseId + "&token=" + textBox_AUTH.Text;
                HttpResponse response = Objects.requestOBJ.Post(url, payload, "application/json");
                if (response.StatusCode == Leaf.xNet.HttpStatusCode.NoContent)
                {
                    Control control = flowLayoutPanel_RELEASES.Controls.Find(Objects.currentInspection.name, true)[0];
                    flowLayoutPanel_RELEASES.Controls.Remove(control);
                    control.Dispose();
                    label_INSPECTION_INFO.Text = @"TITLE
ARTIST
UPC
EMAIL
LANGUAGE
GENRE
LABEL
COPYRIGHT";
                    Objects.currentInspection = null;
                    Objects.currentInspection_DATA = null;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("debug.txt", ex.ToString() + "\n\n\n");
            }
        }
        private void button_INSPECTION_GETDATA_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel_INSPECTION_ARTISTS.Controls.Clear();

                //Get Current Inspection Data
                Objects.currentInspection_DATA = JsonConvert.DeserializeObject<Objects.GetCurrentInspectionData>(Objects.requestOBJ.Get("https://api.revelator.com/content/release/" + Objects.currentInspection.item.releaseId + "?token=" + textBox_AUTH.Text).ToString(), Objects.json_settings);

                //Add Artists to Flowpanel
                foreach(Objects.GetCurrentInspectionDataArtistExternalId artist in Objects.currentInspection_DATA.artistExternalIds)
                {
                    if(artist.distributorStoreId == 9 && artist.profileId != "0")
                    {
                        //CREATE PANEL
                        Panel panel_artist = new Panel();
                        panel_artist.Name = artist.profileId;
                        panel_artist.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        panel_artist.Size = new System.Drawing.Size(48, 48);
                        panel_artist.TabIndex = 1;

                        //ADD CONTROLS TO PANEL
                        PictureBox artist_image = new PictureBox
                        {
                            Size = new Size(45, 45),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(0, 0)
                        };
                        artist_image.Image = (Image)Properties.Resources.SpotifyICO;

                        panel_artist.Controls.Add(artist_image);

                        //PANEL ON CLICK EVENT
                        artist_image.Click += new EventHandler((senderr, ee) => inspection_artist_Click(sender, e, artist.profileId));

                        flowLayoutPanel_INSPECTION_ARTISTS.Controls.Add(panel_artist);
                    }
                }
                string inspection_info_label_text = "TITLE    -    " + Objects.currentInspection_DATA.name;
                inspection_info_label_text+= "\nARTIST    -    " + Objects.currentInspection_DATA.artistName;
                inspection_info_label_text += "\nUPC    -    " + Objects.currentInspection_DATA.upc.ToString();
                if (Objects.currentInspection_DATA.isEnterpriseVip == true)
                {
                    inspection_info_label_text += "\nEMAIL    -    " + Objects.currentInspection_DATA.createdByEmail + " [VIP]";
                }
                else 
                {
                    inspection_info_label_text += "\nEMAIL    -    " + Objects.currentInspection_DATA.createdByEmail;
                }
                inspection_info_label_text += "\nLANGUAGE    -    " + Objects.languages.SingleOrDefault(item => item.languageId == Objects.currentInspection_DATA.languageId).name;
                inspection_info_label_text += "\nGENRE    -    " + Objects.genres.SingleOrDefault(item => item.musicStyleId == Objects.currentInspection_DATA.primaryMusicStyleId).name;
                inspection_info_label_text += "\nLABEL    -    " + Objects.currentInspection_DATA.labelName;
                inspection_info_label_text += "\nCOPYRIGHT    -    " + Objects.currentInspection_DATA.copyrightC + " | " + Objects.currentInspection_DATA.copyrightP;

                label_INSPECTION_INFO.Text = inspection_info_label_text;

                //Add Song Panels with ACR click event
                foreach (Objects.GetCurrentInspectionDataTrack track in Objects.currentInspection_DATA.tracks)
                {
                    //CREATE PANEL
                    Panel panel_song = new Panel();
                    panel_song.Name = Objects.currentInspection_DATA.releaseId.ToString();
                    panel_song.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    panel_song.Size = new System.Drawing.Size(610, 60);
                    panel_song.TabIndex = 1;

                    //ADD CONTROLS TO PANEL
                    PictureBox artist_image = new PictureBox
                    {
                        Size = new Size(55, 55),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(0, 0)
                    };
                    foreach(Objects.GetCurrentInspectionDataScan scan in track.acrCloud.scans)
                    {
                        if (scan.matches != null)
                        {
                            artist_image.Image = (Image)Properties.Resources.SpotifyICO_yellow;
                            break;
                        }
                        else
                        {
                            artist_image.Image = (Image)Properties.Resources.SpotifyICO;
                        }
                    }
                    

                    panel_song.Controls.Add(artist_image);

                    Label to_inspect_track_name = new Label
                    {
                        Size = new Size(550, 30),
                        Location = new Point(60, 0),
                        Text = track.name + " | " + track.artistName,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Label to_inspect_ISRC = new Label
                    {
                        Size = new Size(550, 30),
                        Location = new Point(60, 30),
                        Text = track.isrc + " | " + track.trackId,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    panel_song.Controls.Add(to_inspect_track_name);
                    panel_song.Controls.Add(to_inspect_ISRC);

                    //PANEL ON CLICK EVENT
                    artist_image.Click += new EventHandler((senderr, ee) => inspection_Track_Click(sender, e, track.trackId.ToString()));

                    flowLayoutPanel_INSPECTION_SONGS.Controls.Add(panel_song);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("debug.txt", ex.ToString() + "\n\n\n");
            }
        }
        private void button_EXPORT_BLOCKED_Click(object sender, EventArgs e)
        {
            List<string> tmp_contract_ids_output_list = new List<string>();
            Objects.GETCONTRACTS contracts = JsonConvert.DeserializeObject<Objects.GETCONTRACTS>(Objects.requestOBJ.Get("https://api.revelator.com/accounting/contract/all/summary?orderByDescending=true&orderByProperty=contractId&pageNumber=1&pageSize=1000&token=" + textBox_AUTH.Text).ToString(), Objects.json_settings);
            int tmp_contract_count = Int32.Parse(contracts.totalItemsCount.ToString());
            int cycle_index = 1;
            foreach(Objects.GETCONTRACTSItem contract in contracts.items)
            {
                Objects.getcontracts.Add(contract);
            }
            while(tmp_contract_count > 0) 
            {
                cycle_index++;
                tmp_contract_count = tmp_contract_count - 1000;
                contracts = JsonConvert.DeserializeObject<Objects.GETCONTRACTS>(Objects.requestOBJ.Get("https://api.revelator.com/accounting/payee/all?orderByDescending=true&orderByProperty=payeeId&pageNumber=" + cycle_index + "&pageSize=1000&token=" + textBox_AUTH.Text).ToString(), Objects.json_settings);
                foreach (Objects.GETCONTRACTSItem contract in contracts.items)
                {
                    Objects.getcontracts.Add(contract);
                }
            }
            foreach(Objects.GETCONTRACTSItem contract in Objects.getcontracts)
            {
                if(contract.status == 2)
                {
                    tmp_contract_ids_output_list.Add(contract.contractId.ToString());
                }
            }
            File.WriteAllLines("Blocked_Contract_IDS.txt", tmp_contract_ids_output_list);
        }
    }
}
