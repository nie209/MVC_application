﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVC_application.Models
{
    public class Post_Model
    {
        public long Id { get; set; }
        private string _key;
        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");

                }
                return _key;
            }
            set { _key = value; }
        }
        [Required, StringLength(100,MinimumLength =5)]
        public string Title { get; set; }
    
        public string Author { get; set; }
        [Required, StringLength(500, MinimumLength = 5)]
        public string Body { get; set; }
        [Required]
        public DateTime Posted { get; set; }

    }
}
