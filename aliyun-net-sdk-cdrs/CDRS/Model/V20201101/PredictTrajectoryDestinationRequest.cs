/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class PredictTrajectoryDestinationRequest : RpcAcsRequest<PredictTrajectoryDestinationResponse>
    {
        public PredictTrajectoryDestinationRequest()
            : base("CDRS", "2020-11-01", "PredictTrajectoryDestination")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private string idValue;

		private string idType;

		private int? predictTimeSpan;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string IdValue
		{
			get
			{
				return idValue;
			}
			set	
			{
				idValue = value;
				DictionaryUtil.Add(BodyParameters, "IdValue", value);
			}
		}

		public string IdType
		{
			get
			{
				return idType;
			}
			set	
			{
				idType = value;
				DictionaryUtil.Add(BodyParameters, "IdType", value);
			}
		}

		public int? PredictTimeSpan
		{
			get
			{
				return predictTimeSpan;
			}
			set	
			{
				predictTimeSpan = value;
				DictionaryUtil.Add(BodyParameters, "PredictTimeSpan", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PredictTrajectoryDestinationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PredictTrajectoryDestinationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
