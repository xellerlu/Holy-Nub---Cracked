using System;
using System.Windows.Input;

namespace HamburgerMenu.Controls;

public class RelayCommand : ICommand
{
	private readonly Action<object?> _execute;

	public event EventHandler? CanExecuteChanged;

	public RelayCommand(Action<object?> execute)
	{
		_execute = execute;
	}

	public bool CanExecute(object? parameter)
	{
		return true;
	}

	public void Execute(object? parameter)
	{
		_execute(parameter);
	}
}
