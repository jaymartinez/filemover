using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMover
{
    public class TreeViewObject
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Guid Id { get; set; }

        public Guid ParentId { get; set; }

        /// <summary>
        /// The fully populated DirectoryInfo object as a result of GetDirectories()
        /// </summary>
        public DirectoryInfo DirInfo { get; set; }

        /// <summary>
        /// Whether the object has been added to the search list
        /// </summary>
        public bool IsChosen { get; set; }

        /// <summary>
        /// The number of child directories
        /// </summary>
        public int NumberOfChildren { get; set; }

        public int TreeNodeIndex { get; set; }

        /// <summary>
        /// The corresponding TreeNode object
        /// </summary>
        public TreeNode Node { get; set; }

        public TreeObjectType TreeObjType { get; set; }
    }
}
