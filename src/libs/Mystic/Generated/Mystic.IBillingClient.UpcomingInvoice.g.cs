#nullable enable

namespace Mystic
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Upcoming Invoice
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.GetUpcomingInvoice> UpcomingInvoiceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}