using System.Data;

public class GetAccountInfo 
{
    private ICallHelper _callHelper;
    private ILogger _logger;

    public GetAccountInfo(ILogger logger, ICallHelper callHelper) {
        _logger = logger;
        _callHelper = callHelper;
    }

    public IEnumerable<AccountBalance> GetCustomerAccountBalances(Guid customerId) {
        _logger.LogInformation("Entered method {method}", nameof(GetCustomerAccountBalances));
        var result = _callHelper.ExecuteMainframeCall<GetAccountBalance>(customerId);
        _logger.LogInformation("Exited method {method}", nameof(GetCustomerAccountBalances));
    }

    public IEnumerable<AccountDetails> GetCustomerAccountDetails(Guid customerId) {
    }
}