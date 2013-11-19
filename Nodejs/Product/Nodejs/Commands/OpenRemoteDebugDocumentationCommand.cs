﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudioTools;

namespace Microsoft.NodejsTools.Commands {
    internal sealed class OpenRemoteDebugDocumentationCommand : Command {
        public override void DoCommand(object sender, EventArgs args) {
            // Open explorer to folder
            var filePath = Path.Combine(NodejsPackage.RemoteDebugProxyFolder, "RemoteDebugging.html");
            if (!File.Exists(filePath)) {
                MessageBox.Show(String.Format("Remote Debug Documentation \"{0}\" does not exist.", filePath), "Node.js Tools for Visual Studio");
            } else {
                Process.Start(filePath);
            }
        }

        public override int CommandId {
            get { return (int)PkgCmdId.cmdidOpenRemoteDebugDocumentation; }
        }
    }
}
