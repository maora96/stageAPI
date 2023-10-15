using Microsoft.AspNetCore.Mvc;

namespace stageAPI.Services.ProcessService
{
    public interface IProcessService
    {
        List<Process> GetAllProcessesByDepartment(string department);
        Process GetProcess(int id);
        Process AddProcess(Process process);
        Process UpdateProcess(int id, Process process);
        Process DeleteProcess(int id);
    }
}
