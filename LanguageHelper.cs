
using Microsoft.JSInterop;

public class LanguageHelper
{
    private readonly IJSRuntime _jsRuntime;

    public LanguageHelper(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<bool> GetLanguageState()
    {
        var langPref = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "languagePreference");
        return langPref == "traditional"; // Returns true for Traditional, false for Modern
    }
}