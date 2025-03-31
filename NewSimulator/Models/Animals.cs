using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class Animals
{
    private string _description = string.Empty;

    public required string Description 
    {
        get => _description;
        init
        {
            _description = Validator.StringValidator(value, 3, 15, '#');
        } 
    }
    public uint Size { get; set; } = 3;
    public virtual string Info => $"{Description} <{Size}>";

    public override string ToString()
    {
        return $"{GetType().Name.ToUpper()} : {Info}";
    }
}
