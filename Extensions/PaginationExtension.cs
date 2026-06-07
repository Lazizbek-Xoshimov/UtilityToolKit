namespace UtilityToolKit.Extensions;

public static class PaginationExtension
{
    public static IEnumerable<int> Paginate(this IEnumerable<int> numbers, int page, int pageSize) =>
        numbers.Skip((page - 1) * pageSize).Take(pageSize);
}