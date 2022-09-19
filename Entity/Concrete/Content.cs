using System;
using System.ComponentModel.DataAnnotations;

public class Content
{

    [Key]
    public int ContentID { get; set; }

    [StringLength(1000)]
    public string ContentValue { get; set; }

    public DateTime ContentDate { get; set; }

    //ContentYazar.
    //ContentBaşlık.

    public int HeadingId { get; set; }
    public virtual Heading Heading { get; set; }

    public int? WriterID { get; set; }

    public virtual Writer Writer { get; set; }

}
