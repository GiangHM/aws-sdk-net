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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchPutAssetPropertyValue Request Marshaller
    /// </summary>       
    public class BatchPutAssetPropertyValueRequestMarshaller : IMarshaller<IRequest, BatchPutAssetPropertyValueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutAssetPropertyValueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchPutAssetPropertyValueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/properties";
            using (MemoryStream memoryStream = new MemoryStream())
            {
<<<<<<< HEAD
                using (StreamWriter streamWriter = new InvariantCultureStreamWriter(memoryStream))
||||||| Commit version number update changes
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEntries())
=======
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEnablePartialEntryProcessing())
                {
                    context.Writer.WritePropertyName("enablePartialEntryProcessing");
                    context.Writer.Write(publicRequest.EnablePartialEntryProcessing);
                }

                if(publicRequest.IsSetEntries())
>>>>>>> 155cf7e693f514d013f0b7a90cc36b7db1c33d52
                {
                    JsonWriter writer = new JsonWriter(streamWriter);
                    writer.Validate = false;
                    writer.WriteObjectStart();
                    var context = new JsonMarshallerContext(request, writer);
                    if(publicRequest.IsSetEntries())
                    {
                        context.Writer.WritePropertyName("entries");
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestEntriesListValue in publicRequest.Entries)
                        {
                            context.Writer.WriteObjectStart();

                            var marshaller = PutAssetPropertyValueEntryMarshaller.Instance;
                            marshaller.Marshall(publicRequestEntriesListValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }

                    writer.WriteObjectEnd();
                }

                request.Content = memoryStream.ToArray();
            }

            
            request.HostPrefix = $"data.";

            return request;
        }
        private static BatchPutAssetPropertyValueRequestMarshaller _instance = new BatchPutAssetPropertyValueRequestMarshaller();        

        internal static BatchPutAssetPropertyValueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchPutAssetPropertyValueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}