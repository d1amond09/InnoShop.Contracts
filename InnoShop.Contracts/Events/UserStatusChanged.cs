namespace InnoShop.Contracts.Events;

public record UserStatusChanged
{
	public Guid UserId { get; init; }
	public bool IsActive { get; init; }
}
