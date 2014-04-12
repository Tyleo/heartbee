using DrK.Heartbee.Utilities.Extensions;
using System;
using System.Windows.Input;

namespace DrK.Heartbee.Utilities.Classes
{
    /// <summary>
    /// Encapsulates an Action so that it may be called remotely.
    /// </summary>
    public sealed class ActionCommand :
        ICommand
    {
        private readonly Func<object, bool> _canExecuteFunc;
        private readonly Action<object> _executeAction;

        /// <summary>
        /// Raised when changes occur that affect whether or not the command
        /// should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Invokes the CanExecuteChanged event.
        /// </summary>
        public void InvokeCanExecuteChanged()
        {
            CanExecuteChanged.InvokeIfInstantiated(this, new EventArgs());
        }

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">
        /// Data used to determine whether the command can execute. If
        /// determining whether the command can execute does not require data
        /// to be passed, this object can be set to null.
        /// </param>
        /// <returns>
        /// True if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return _canExecuteFunc(parameter);
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">
        /// Data used by the command. If the command does not require data to
        /// be passed, this object can be set to null.
        /// </param>
        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }

        /// <summary>
        /// Creates a new ActionCommand.
        /// </summary>
        /// <param name="action">
        /// The Action to encapsulate.
        /// </param>
        /// <param name="canExecuteFunc">
        ///  Determines whether the command can execute in its current state.
        ///  If the method can always execute, this Func can be set to null.
        /// </param>
        public ActionCommand(Action<object> action, Func<object, bool> canExecuteFunc = null)
        {
            _executeAction = action;
            _canExecuteFunc = canExecuteFunc ?? ((o) => true);
        }
    }
}
