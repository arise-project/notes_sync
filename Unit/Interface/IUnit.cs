using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

namespace notes_sync.Unit.Interface
{
    public interface IUnit
    {
        UnitType UnitType {get;}
        bool Run(string[] args);
    }
}
