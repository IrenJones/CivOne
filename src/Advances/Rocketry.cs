// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.Enums;

namespace CivOne.Advances
{
	internal class Rocketry : BaseAdvance
	{
		public Rocketry() : base(8, 0, 1, Advance.AdvancedFlight, Advance.Electronics)
		{
			Name = "Rocketry";
			Type = Advance.Rocketry;
		}
	}
}