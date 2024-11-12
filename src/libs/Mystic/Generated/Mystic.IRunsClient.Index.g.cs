#nullable enable

namespace Mystic
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of runs that satisfy query parameters.<br/>
        /// Supported query params:<br/>
        /// - `pipeline_id`: filter by a given pipeline ID<br/>
        ///     - e.g. `pipeline_id=pipeline_some-random-string`<br/>
        /// - `order_by`: order by a given field<br/>
        ///     - supported fields are `created_at`, `state`, `compute_time_ms`; default<br/>
        ///         is `created_at:desc`<br/>
        ///     - e.g. `order_by=compute_time_ms:desc`<br/>
        /// - include_pointers: include any pointers that point to the pipelines the runs were<br/>
        /// executed against
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedRunGet> IndexAsync(
            string? pipelineId = default,
            bool? includePointers = default,
            int? skip = default,
            int? limit = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}