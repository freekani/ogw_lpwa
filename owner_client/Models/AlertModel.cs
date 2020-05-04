using System.Runtime.Serialization;
[DataContract]
public class AlertModel
{
    [DataMember(Name = "head")]
    public string Head { get; set; }
    [DataMember(Name = "body")]
    public string Body { get; set; }
}