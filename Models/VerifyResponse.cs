using System;
public class VerifyResponse
{
    // This can be used in replacement of a unique Membership Id
    public int Id { get; set; }

    public bool IsValid { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    // this needs to be unique
    public string Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Country { get; set; }

    public string Region { get; set; }

    public string Address { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string Postal { get; set; }

    public string Gender { get; set; }

    //(Administrator, Athlete, Coach, Official, Other, Parent, Volunteer)
    public string Position { get; set; }

    // Membership Id, this can be unique and it is sometimes a guid or uuid.
    public string MembershipId { get; set; }

    // Membership expiration can be used if you want to require your members to verify again
    public DateTime MembershipExpiration { get; set; }


}