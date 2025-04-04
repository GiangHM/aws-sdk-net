/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// The <c>MedicalTranscript</c> associated with a <code/>.
    /// 
    ///  
    /// <para>
    ///  <c>MedicalTranscript</c> contains <c>Results</c>, which contains a set of transcription
    /// results from one or more audio segments, along with additional information per your
    /// request parameters.
    /// </para>
    /// </summary>
    public partial class MedicalTranscript
    {
        private List<MedicalResult> _results = AWSConfigs.InitializeCollections ? new List<MedicalResult>() : null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Contains a set of transcription results from one or more audio segments, along with
        /// additional information per your request parameters. This can include information relating
        /// to alternative transcriptions, channel identification, partial result stabilization,
        /// language identification, and other transcription-related data.
        /// </para>
        /// </summary>
        public List<MedicalResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}