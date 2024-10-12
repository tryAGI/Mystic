#nullable enable

namespace Mystic
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a new file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(
            global::Mystic.BodyCreateV4FilesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create<br/>
        /// Create a new file.
        /// </summary>
        /// <param name="pfile"></param>
        /// <param name="pfilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(
            byte[] pfile,
            string pfilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}