﻿using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.ASLists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetAlbumList2 : Response<GetAlbumList2>
    {
        [XmlArray("albumList2")]
        [XmlArrayItem("album")]
        public List<Album> Albums { get; set; }

        public async Task Init(AlbumListTypeEnum type, int size = 10, int offset = 0)
        {
            GetAlbumList2 rs = await Get("&type=" + Constants.AlbumListType[type] + "&size=" + size + "&offset=" + offset);
            this.Copy(rs);
            this.Albums = new List<Album>(rs.Albums);
        }
    }
}
