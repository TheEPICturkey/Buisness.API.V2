namespace BusinessApi.Models
{
  public class PaginationParams
  {
    private const int _maxItemsPerPage = 5;
    private int _itemsPerPage = 5;

    public int Page { get; set; } = 1;
    public int ItemsPerPage
    {
      get => _itemsPerPage;
      set => _itemsPerPage = value > _maxItemsPerPage ? _maxItemsPerPage : value;
    }
  }
}