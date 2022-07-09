namespace Kubesharp.Api.Controller.Kube;

public class NamespaceController : BaseApiController
{
    private readonly IKubeNamespaceService _namespaceService;

    public NamespaceController(IKubeNamespaceService namespaceService)
    {
        _namespaceService = namespaceService;
    }

    // GET: api/Projects
    [HttpGet]
    public async Task<IActionResult> ListAsync()
    {
        var namespaces = await _namespaceService
            .ListAsync(this.HttpContext.RequestAborted);

        var result = namespaces.Select(n => n.Name);

        return this.Ok(result);
    }

    // GET: api/Projects/{name:string}
    [HttpGet("{name:string}")]
    public async Task<IActionResult> GetByNameAsync(string name)
    {
        var @namespace = await _namespaceService
            .GetAsync(name, this.HttpContext.RequestAborted);

        return this.Ok(@namespace.ToDto());
    }
}