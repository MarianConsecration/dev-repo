using Microsoft.JSInterop;
using System.Threading.Tasks;

public class LanguageHelper
{
    private readonly IJSRuntime _jsRuntime;

    // The constructor gets the JS runtime via dependency injection
    public LanguageHelper(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    // This method will be called from each page to check the setting
    public async Task<bool> GetIsTraditional()
    {
        // We use "language" to match the key set by your LanguageToggle component
        var langPref = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "language");

        // This will return 'true' if the stored value is "traditional", and 'false' otherwise
        return langPref == "traditional";
    }
}
