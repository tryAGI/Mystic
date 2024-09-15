#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create<br/>
        /// Upload a new pipeline.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CreateAsync(
            global::Mystic.PipelineCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create<br/>
        /// Upload a new pipeline.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="cluster"></param>
        /// <param name="scalingConfig"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="extras"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CreateAsync(
            string name,
            string image,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable> inputVariables,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable> outputVariables,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators = default,
            global::Mystic.PipelineClusterConfig? cluster = default,
            string? scalingConfig = default,
            string? description = default,
            string? readme = default,
            global::Mystic.PipelineCreateExtras? extras = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}