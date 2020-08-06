using System;
using System.Threading.Tasks;
using BTCPayServer;
using BTCPayServer.Data;
using BTCPayServer.Payments;

public interface IPayoutHandler
{
    public bool CanHandle(PaymentMethodId paymentMethod);
    public Task TrackClaim(PaymentMethodId paymentMethodId, IClaimDestination claimDestination);
    public Task<IClaimDestination> ParseClaimDestination(PaymentMethodId paymentMethodId, string destination);
    void StartBackgroundCheck(Action<Type[]> subscribe);
    Task BackgroundCheck(object o);
}