using Microsoft.AspNetCore.Components;

namespace ThreeTacos.Tacomponents.Bootstrap.VanillaV5;

public partial class BootstrapComponentBase : ComponentBase
{
    /// <summary>
    /// Set the Bootstrap 5 col-xs-x column size dynamically.
    /// </summary>
    [Parameter]
    public string ColumnSizeXs
    {
        get => $"{ColXs}{_columnXsValue}";
        set => _columnXsValue = value;
    }
    
    /// <summary>
    /// Set the Bootstrap 5 col-sm-x column size dynamically.
    /// </summary>
    [Parameter]
    public string ColumnSizeS
    {
        get => $"{ColS}{_columnSValue}";
        set => _columnSValue = value;
    }
  
    /// <summary>
    /// Set the Bootstrap 5 col-md-x column size dynamically.
    /// </summary>
    [Parameter]
    public string ColumnSizeM
    {
        get => $"{ColM}{_columnMValue}";
        set => _columnMValue = value;
    }
    
    /// <summary>
    /// Set the Bootstrap 5 col-lg-x column size dynamically.
    /// </summary>
    [Parameter]
    public string ColumnSizeL
    {
        get => $"{ColL}{_columnLValue}";
        set => _columnLValue = value;
    }
    
    /// <summary>
    /// Set the Bootstrap 5 col-xl-x column size dynamically.
    /// </summary>
    [Parameter]
    public string ColumnSizeXL
    {
        get => $"{ColXl}{_columnXlValue}";
        set => _columnXlValue = value;
    }

    private string _columnXsValue = "";
    private string _columnSValue = "";
    private string _columnMValue = "";
    private string _columnLValue = "";
    private string _columnXlValue = "";
    private const string ColXs = "col-xs-";
    private const string ColS = "col-sm-";
    private const string ColM = "col-md-";
    private const string ColL = "col-lg-";
    private const string ColXl = "col-xl-";
}