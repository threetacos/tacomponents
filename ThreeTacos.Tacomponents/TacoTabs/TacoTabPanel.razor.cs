using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;

namespace ThreeTacos.Tacomponents.TacoTabs;

public partial class TacoTabPanel
{
    private const string BASE_CSS = "tacotab-container";
    
    [Parameter] 
    public RenderFragment ChildContent { get; set; }
    
    [Parameter] 
    public string CssClasses { get; set; }
    
    [Parameter] 
    public string CssStyles { get; set; }

    public string CssClass => new CssBuilder(BASE_CSS)
        .AddClass(CssClasses)
        .Build();

    public string CssStyle => StyleBuilder.Empty()
        .AddStyle(CssStyles)
        .Build();
}