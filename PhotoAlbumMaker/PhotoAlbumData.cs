﻿using System.Collections.Generic;


namespace PhotoAlbumMaker
{

    public class ImageInfo
    {
        public string N { get; set; } //name
        public string C { get; set; } //comments
        public string D { get; set; } //date-time
        public string Cn { get; set; } //camera name
        public string I { get; set; } //iso
        public string F { get; set; } //focal length
        public string E { get; set; } //exposure
        public string A { get; set; } //aperture
        public string La { get; set; } //gps latitude
        public string Lo { get; set; } //gps longitude
        public string Al { get; set; } //gps altitude
    }

    public class VideoInfo
    {
        public string N { get; set; } //name
        public string D { get; set; } //description
    }

    public class FolderInfo
    {
        public FolderInfo()
        {
            Im = new List<ImageInfo>();
            V = new List<VideoInfo>();
        }
        public int I { get; set; }  //id
        public string N { get; set; } //name
        public int PI { get; set; } //parent id
        public string C { get; set; } //comments
        public int TF { get; set; } //thumb folder
        public string TN { get; set; } //thumb name
        public List<ImageInfo> Im { get; set; }
        public List<VideoInfo> V { get; set; }
    }

    public class PhotoAlbumData
    {
        public PhotoAlbumData()
        {
            F=new List<FolderInfo>();
        }
        public string N { get; set; } //name
        public string D { get; set; } //description
        public int IS { get; set; } //images size
        public byte IQ { get; set; } //images quality
        public int TS { get; set; } //thumbs size
        public byte TQ { get; set; } //thumbs quality
        public int TIC { get; set; } //total images count
        public int TVC { get; set; } //total videos count
        public string LC { get; set; } //last changed

        public List<FolderInfo> F { get; set; }

    }
}
