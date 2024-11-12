#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Patch Image<br/>
        /// Update the image avatar of a pipeline. The new image url<br/>
        /// will be available in the response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchImageAsync(
            string pipelineId,
            global::Mystic.BodyPatchImageV4PipelinesPipelineIdImagePatch request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch Image<br/>
        /// Update the image avatar of a pipeline. The new image url<br/>
        /// will be available in the response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchImageAsync(
            string pipelineId,
            byte[] imageFile,
            string imageFilename,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}