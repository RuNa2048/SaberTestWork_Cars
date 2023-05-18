//Облегчённый способ работы с деталями и их хранением

namespace SaberTestWork;

public class Parts
{
    public List<ImportantPart> ImportantParts { get; }
    public List<DecorPart> DecorParts { get; }

    public Parts(List<ImportantPart> importantParts, List<DecorPart> decorParts)
    {
        ImportantParts = importantParts;
        DecorParts = decorParts;
    }
}