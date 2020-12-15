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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDedicatedHostGroupAttributeRequest : RpcAcsRequest<ModifyDedicatedHostGroupAttributeResponse>
    {
        public ModifyDedicatedHostGroupAttributeRequest()
            : base("Rds", "2014-08-15", "ModifyDedicatedHostGroupAttribute", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? cpuAllocationRatio;

		private string dedicatedHostGroupId;

		private string resourceOwnerAccount;

		private int? diskAllocationRatio;

		private int? memAllocationRatio;

		private long? ownerId;

		private string hostReplacePolicy;

		private string dedicatedHostGroupDesc;

		private string allocationPolicy;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? CpuAllocationRatio
		{
			get
			{
				return cpuAllocationRatio;
			}
			set	
			{
				cpuAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "CpuAllocationRatio", value.ToString());
			}
		}

		public string DedicatedHostGroupId
		{
			get
			{
				return dedicatedHostGroupId;
			}
			set	
			{
				dedicatedHostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostGroupId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? DiskAllocationRatio
		{
			get
			{
				return diskAllocationRatio;
			}
			set	
			{
				diskAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "DiskAllocationRatio", value.ToString());
			}
		}

		public int? MemAllocationRatio
		{
			get
			{
				return memAllocationRatio;
			}
			set	
			{
				memAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "MemAllocationRatio", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string HostReplacePolicy
		{
			get
			{
				return hostReplacePolicy;
			}
			set	
			{
				hostReplacePolicy = value;
				DictionaryUtil.Add(QueryParameters, "HostReplacePolicy", value);
			}
		}

		public string DedicatedHostGroupDesc
		{
			get
			{
				return dedicatedHostGroupDesc;
			}
			set	
			{
				dedicatedHostGroupDesc = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostGroupDesc", value);
			}
		}

		public string AllocationPolicy
		{
			get
			{
				return allocationPolicy;
			}
			set	
			{
				allocationPolicy = value;
				DictionaryUtil.Add(QueryParameters, "AllocationPolicy", value);
			}
		}

        public override ModifyDedicatedHostGroupAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDedicatedHostGroupAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
