
public class StaticData
{
    public int npts { get; set; }
    public int njams { get; set; }
    public int mode { get; set; }
    public float[] workmodeinfo { get; set; }
    public float[] begposition { get; set; }
    public float[] endposition { get; set; }
    public float[] curposition { get; set; }
    public int heading { get; set; }
    public int velocity { get; set; }
    public int sardirection { get; set; }
    public int sarsweepangle { get; set; }
    public int sarpt { get; set; }
    public int sargt { get; set; }
    public float wavelength { get; set; }
    public int bandwidth { get; set; }
    public float pulsewidth { get; set; }
    public int repetitionfreq { get; set; }
    public float sarsysloss { get; set; }
    public float sartransloss { get; set; }
    public int synthetictime { get; set; }
    public float beamwidthA { get; set; }
    public float beamwidthR { get; set; }
    public float reflectance { get; set; }
    public int elementsA { get; set; }
    public int elementsR { get; set; }
    public float elementdisA { get; set; }
    public float elementdisR { get; set; }
    public Jammer[] jammer { get; set; }
}

public class Jammer
{
    public int serialNO { get; set; }
    public int flagtrack { get; set; }
    public int jamtype { get; set; }
    public float lon { get; set; }
    public float lat { get; set; }
    public float alt { get; set; }
    public int pj { get; set; }
    public int gj { get; set; }
    public float bwj { get; set; }
    public float recvloss { get; set; }
    public int beamheading { get; set; }
    public int beampitch { get; set; }
    public int beamwidth { get; set; }
}
