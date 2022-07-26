<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

void Main()
{
	new NavigationBar(new Android());
	new NavigationBar(new Apple());
	new DropdownMenu(new Android());
	new DropdownMenu(new Apple());
}

public class NavigationBar
{
	public NavigationBar(IUIFactory factory) => factory.CreateButton();
}

public class DropdownMenu
{
	public DropdownMenu(IUIFactory factory) => factory.CreateButton();
}

public interface IUIFactory
{
	public Button CreateButton();
}

public class Apple : IUIFactory
{
	public Button CreateButton()
	{
		return new Button { Type = "iOS Button".Dump() };
	}
}

public class Android : IUIFactory
{
	public Button CreateButton()
	{
		return new Button { Type = "Android Button".Dump() };
	}
}

public class Button
{
	public string Type { get; set; }
}