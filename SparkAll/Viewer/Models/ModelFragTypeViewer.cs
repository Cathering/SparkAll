﻿/**********************************************************************\

 Spark All
 Copyright (C) 2013 Cathering
 Copyright (C) 2008 Arushan/Aru <oneforaru at gmail.com>

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

\**********************************************************************/

using System.IO;
using System.Windows.Forms;
using RageLib.Models;

namespace SparkAll.Viewer.Models
{
    class ModelFragTypeViewer : ModelViewer
    {
        #region Implementation of IViewer

        public override Control GetView(RageLib.FileSystem.Common.File file)
        {
            var data = file.GetData();

            var ms = new MemoryStream(data);
            var modelFile = new ModelFragTypeFile();
            try
            {
                modelFile.Open(ms);
            }
            catch
            {
                return null;
            }
            finally
            {
                ms.Close();
            }

            return CreateControl(file, modelFile);
        }

        #endregion
    }
}