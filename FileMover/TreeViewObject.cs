using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover
{
    public class TreeViewObject
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The fully populated DirectoryInfo object as a result of GetDirectories()
        /// </summary>
        public DirectoryInfo DirInfo { get; set; }

        /// <summary>
        /// Whether the object has been added to the search list
        /// </summary>
        public bool IsChosen { get; set; }

        /// <summary>
        /// The file types to search for
        /// </summary>
        public List<string> FileTypes { get; set; }

        /// <summary>
        /// Where to copy the files to
        /// </summary>
        public string DestinationPath { get; set; }
    }
}
