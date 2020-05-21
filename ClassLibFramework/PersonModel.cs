﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSand_2020a.ClassLibFrameWork
{
    public class PersonModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string FullName
        {
            get { return $"{FirstName} { LastName }"; } 
        }

    }
}
