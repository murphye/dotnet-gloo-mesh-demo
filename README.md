# .NET 6 Microservices with Gloo Mesh Demo

This demo project shows how to use Gloo Mesh from a application developer's perspective when building .NET 6 microservices.

## Prerequisites

* Gloo Mesh 1.2 installed on a Kubernetes (probably AKS) cluster
* Gloo Mesh Gateway is installed for Kubernetes ingress and API Gateway capabilities
* `dotnet` 6.0 is installed on the developer's local machine
* `kubectl` is installed on the developer's local machine and the developer can deploy configs to a namespace in the cluster

## Architecture



## Features Demonstrated

## Ingress and API Gateway
* `RouteTable` configuration

### Zero-Trust Networking
* mTLS Encryption
* `TrafficPolicy`
* 

## Role-Based API (for Administrators)

* https://docs.solo.io/gloo-mesh-enterprise/latest/guides/role_based_api/using_role_based_api/

## Traffic Routing

* [`ServiceDependency`](https://docs.solo.io/gloo-mesh-enterprise/main/guides/traffic_routing/service_dependencies/)


* [East-West Rate Limiting](https://docs.solo.io/gloo-mesh-enterprise/latest/guides/east_west/ew_ratelimit/)


## GitOps

