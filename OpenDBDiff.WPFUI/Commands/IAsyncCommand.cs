using System.Threading.Tasks;
using System.Windows.Input;

namespace OpenDBDiff.WPFUI.Commands
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
