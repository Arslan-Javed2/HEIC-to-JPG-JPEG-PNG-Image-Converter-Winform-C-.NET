using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter.Models
{
    public class FileInformation
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize {  get; set; }
    }
}
