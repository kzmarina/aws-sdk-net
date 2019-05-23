/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DisableEbsEncryptionByDefault operation.
    /// </summary>
    public partial class DisableEbsEncryptionByDefaultResponse : AmazonWebServiceResponse
    {
        private bool? _ebsEncryptionByDefault;

        /// <summary>
        /// Gets and sets the property EbsEncryptionByDefault. 
        /// <para>
        /// Account-level encryption status after performing the action.
        /// </para>
        /// </summary>
        public bool EbsEncryptionByDefault
        {
            get { return this._ebsEncryptionByDefault.GetValueOrDefault(); }
            set { this._ebsEncryptionByDefault = value; }
        }

        // Check to see if EbsEncryptionByDefault property is set
        internal bool IsSetEbsEncryptionByDefault()
        {
            return this._ebsEncryptionByDefault.HasValue; 
        }

    }
}