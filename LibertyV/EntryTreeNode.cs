﻿/*
 
    LibertyV - Viewer/Editor for RAGE Package File version 7
    Copyright (C) 2013  koolk <koolkdev at gmail.com>
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
  
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
   
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibertyV.Rage.RPF.V7.Entries;

namespace LibertyV
{
    public class EntryTreeNode : TreeNode
    {
        public DirectoryEntry Entry;
        public EntryTreeNode(DirectoryEntry entry, EntryTreeNode[] children)
            : base(entry.Name, children)
        {
            this.Entry = entry;
            entry.Node = this;
        }
    }
}
