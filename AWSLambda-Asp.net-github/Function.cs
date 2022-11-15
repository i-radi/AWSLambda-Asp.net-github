using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AWSLambda_Asp.net_github;

public class Function
{
    public string FunctionHandler(Temperature model, ILambdaContext context)
    {
        var result = $"Celsius: {model.Celsius} = Fahrenheit: {(model.Celsius * 9) / 5 + 32}";
        //Console.WriteLine(result);
        return result;
    }
}
public class Temperature
{
    public double Celsius { get; set; }
}