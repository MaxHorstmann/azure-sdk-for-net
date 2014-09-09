// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Insights.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Insights
{
    /// <summary>
    /// Operations for managing the collection of diagonstics and monitoring
    /// data.
    /// </summary>
    public partial interface IMonitoringConfigurationOperations
    {
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateOrUpdateConfigurationAsync(string resourceUri, MonitoringConfigurationCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update monitoring setting response. It's marked as
        /// empty. We only pass it to ensure json error handling.
        /// </returns>
        Task<MonitoringConfigurationCreateOrUpdateResponse> CreateOrUpdateStorageConfigurationAsync(string resourceUri, CreateOrUpdateStorageConfigurationParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<MonitoringConfigurationGetResponse> GetConfigurationAsync(string resourceUri, CancellationToken cancellationToken);
        
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<StorageConfigurationGetResponse> GetStorageConfigurationAsync(string resourceUri, CancellationToken cancellationToken);
        
        /// <param name='resourceUri'>
        /// The resource identifier for the configuration.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateConfigurationAsync(string resourceUri, MonitoringConfigurationCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateStorageConfigurationAsync(string resourceUri, CreateOrUpdateStorageConfigurationParameters parameters, CancellationToken cancellationToken);
    }
}
