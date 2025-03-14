public class BudgetModel
{
    public string? Name { get; set; }
    public decimal Amount { get; set; }
}

public class MoneyGoalModel
{
    public string? Name { get; set; }
    public decimal Amount { get; set; }
}

public class DashboardViewModel
{
    public List<BudgetModel>? Budgets { get; set; }
    public List<MoneyGoalModel>? Goals { get; set; }
    public decimal TotalSpent { get; set; }
    public decimal RemainingBudget { get; set; }
}
