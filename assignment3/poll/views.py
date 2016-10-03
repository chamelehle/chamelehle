from django.http import HttpResponse
from django.http import HttpRequest
from django.shortcuts import render
from django.template import RequestContext

def index(request):
    assert isinstance(request, HttpRequest)
    return render(request, 'helloWorld.html',)
