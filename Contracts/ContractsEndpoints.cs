using Microsoft.EntityFrameworkCore;
using ShippingCompanyContracts.Contracts.Camilo;
using ShippingCompanyContracts.Data;

namespace ShippingCompanyContracts.Contracts;

public static class ContractsEndpoints
{
    public static void AddEndpointsContracts(this WebApplication app)
    {
        var endpoint = app.MapGroup("contracts");
        
        // Create Camilo
        endpoint.MapPost("/camilo", async (List<Camilo.Camilo> list, AppDbContext context, CancellationToken ct) =>
        {
            if (list.Count == 0)
            {
                return Results.BadRequest("Invalid data.");
            }

            await context.Camilos.AddRangeAsync(list, ct);
            await context.SaveChangesAsync(ct);
            return Results.Ok(list);
        });
        // Find Camilo
        endpoint.MapGet("/camilo", async (AppDbContext context, CancellationToken ct) =>
        {
            var camilo = await context.Camilos.ToListAsync(ct);
            return camilo;
        });
        // Update All Camilo
        endpoint.MapPut("/camilo", (CancellationToken ct) => { });
        // Delete All Camilo
        endpoint.MapDelete("/camilo/{id}", (CancellationToken ct) => { });
    }
}