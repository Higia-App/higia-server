﻿using Task = System.Threading.Tasks.Task;

namespace HigiaServer.Application.Interfaces;

public interface ICollaboratorService
{
    Task<List<CollaboratorDTO>> GetCollaborators();
    Task<CollaboratorDTO> GetCollaboratorById(Guid id);

    Task CreateCollaborator(CreateCollaboratorDTO collaboratorDto);
    Task UpdateCollaborator(CollaboratorDTO collaboratorDto);
    Task DeleteCollaborator(Guid id);

    Task AddTask(Guid id, Domain.Entities.Task task);
    Task<List<TaskDTO>> GetTasksFromCollaborator(Guid id);
}