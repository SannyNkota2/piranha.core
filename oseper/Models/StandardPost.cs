using Piranha.AttributeBuilder;
using Piranha.Models;

namespace oseper.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}