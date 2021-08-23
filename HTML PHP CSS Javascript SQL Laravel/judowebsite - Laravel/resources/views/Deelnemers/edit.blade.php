@extends('app')

@section('content')
<form method="post" action="{{ route('deelnemer.update', $deelnemer->id) }}">
    @method('PATCH')
    <div class="form-group">
        @csrf
        <label>Naam:</label>
        <input type="text" class="form-control" name="naam" value="{{$deelnemer->naam}}"/>
    </div>
    <div class="form-group">
        <label>Band</label>
        <select class="form-control" name="banden_id" required>
            @foreach($banden as $band)
            <option value="{{$band->id}}"
            @if ($deelnemer->banden_id == $band->id)
                selected
            @endif
            >{{$band->NL_naam}}</option>
            @endforeach
        </select>
    </div>
    <div class="form-group">
        <label>Aantal keer gewonnen:</label>
        <input type="text" class="form-control" name="win" value="{{$deelnemer->win}}"/>
    </div>
    <div class="form-group">
        <label>Aantal keer verloren:</label>
        <input type="text" class="form-control" name="loss" value="{{$deelnemer->loss}}"/>
    </div>
    <button type="submit" class="btn btn-primary">Aanpassen</button>
</form>
@endsection
