# How to testing

## Run performance tests

Performance tests use Grafana K6 service.

Prerequirements to run tests:
- Docker
- Enabled running PowerShell scripts (https://superuser.com/a/106363)

### Issue dispatcher testing

- Go to `src/scripts` folder
- In PowerShell run command `./run-dispatching.test.ps1`