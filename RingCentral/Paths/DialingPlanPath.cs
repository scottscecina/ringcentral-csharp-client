using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DialingPlanPath : PathSegment
    {
        internal DialingPlanPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "dialing-plan";
            }
        }
    }
}
