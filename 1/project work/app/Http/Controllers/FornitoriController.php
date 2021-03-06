<?php

namespace App\Http\Controllers;

use App\Models\Fornitore;
use App\Models\Product;
use Illuminate\Http\Request;
use App\Http\Requests\FornitoreRequest;

class FornitoriController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $items=Fornitore::get();
        return view('fornitore.index',compact('items'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $product=Product::all();

        return view('fornitore.create',compact('product'));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(FornitoreRequest $request)
    {
        $fornitore=new Fornitore();
        $fornitore->create($request->input('fornitore'));
        return redirect('/fornitores');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit(Fornitore $fornitore)
    {

        return view('fornitore.edit',compact('fornitore'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(FornitoreRequest $request, Fornitore $fornitore)
    {
        $fornitore->update($request->input('fornitore'));
        return redirect('/fornitores');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $fornitore=new Fornitore();
        $items=$fornitore->find($id);
        $items->delete();
        return redirect('/fornitores');
    }
}
