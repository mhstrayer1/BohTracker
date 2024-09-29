namespace BohTracker
{
   public static partial class DataModel
   {
      public class PrinciplesList
      {
         public PrinciplesList
            (
               int edge = 0,
               int forge = 0,
               int grail = 0,
               int heart = 0,
               int knock = 0,
               int lantern = 0,
               int moon = 0,
               int moth = 0,
               int nectar = 0,
               int rose = 0,
               int scale = 0,
               int sky = 0,
               int winter = 0
            )
         {
            for (var i = 0; i < 13; i++)
               PrnList.Add(0);

            PrnList[(int)PrincipleEnum.Edge] = edge;
            PrnList[(int)PrincipleEnum.Forge] = forge;
            PrnList[(int)PrincipleEnum.Grail] = grail;
            PrnList[(int)PrincipleEnum.Heart] = heart;
            PrnList[(int)PrincipleEnum.Knock] = knock;
            PrnList[(int)PrincipleEnum.Lantern] = lantern;
            PrnList[(int)PrincipleEnum.Moon] = moon;
            PrnList[(int)PrincipleEnum.Moth] = moth;
            PrnList[(int)PrincipleEnum.Nectar] = nectar;
            PrnList[(int)PrincipleEnum.Rose] = rose;
            PrnList[(int)PrincipleEnum.Scale] = scale;
            PrnList[(int)PrincipleEnum.Sky] = sky;
            PrnList[(int)PrincipleEnum.Winter] = winter;
         }

         public List<int> PrnList { get; } = new List<int>(13);

         public void CopyFrom(PrinciplesList otherList)
         {
            for (var i = 0; i < PrnList.Count; i++) PrnList[i] = otherList.PrnList[i];
         }

         public void CopyTo(PrinciplesList otherList)
         {
            for (var i = 0; i < PrnList.Count; i++) otherList.PrnList[i] = PrnList[i];
         }

         public void AddFrom(PrinciplesList otherList)
         {
            for (var i = 0; i < PrnList.Count; i++) PrnList[i] += otherList.PrnList[i];
         }
      }
   }
}