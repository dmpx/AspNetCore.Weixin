﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Weixin
{
    /// <summary>
    /// 上传媒体文件返回结果
    /// </summary>
    public class MediaUploadResultJson : WeixinErrorJson
    {
        public UploadMediaType type;
        public string media_id;
        public long created_at;
    }
}
