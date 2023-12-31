using System.Data;

public class SqlHelper 
{

    public decimal CalculateInterest(Guid productId, string currency) {
        using (var con = new SqlConnection(_constr)) 
        using (var cmd = con.CreateCommand())
        {
            return cmd.ExecuteScalar(@"
                select 
                    [FX].[FXRate] * [Product].[LinePrice] 
                where 
                    [Product].ProductId = " + ProductId + @"
                    AND [FX].[Currency] = '" + currency + "'");
        }
    }
}